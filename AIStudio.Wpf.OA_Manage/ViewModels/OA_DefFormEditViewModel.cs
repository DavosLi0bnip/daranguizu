﻿using Aga.Diagrams.TestExtend.Flowchart;
using AIStudio.Wpf.BasePage.ViewModels;
using AIStudio.Wpf.Business.DTOModels;
using AIStudio.Wpf.OA_Manage.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AIStudio.Wpf.OA_Manage.ViewModels
{
    public class OA_DefFormEditViewModel : BaseEditViewModel<OA_DefFormDTO>
    {
        private FlowchartModel _flowchartModel;
        public FlowchartModel FlowchartModel
        {
            get { return _flowchartModel; }
            set
            {
                SetProperty(ref _flowchartModel, value);
            }
        }

        public OAData OAData { get; set; }

        private string _mode = "Edit";
        public string Mode
        {
            get { return _mode; }
            set
            {
                SetProperty(ref _mode, value);
            }
        }

        private List<OA_DefTypeDTO> _types;
        public List<OA_DefTypeDTO> Types
        {
            get { return _types; }
            set
            {
                SetProperty(ref _types, value);
            }
        }

        private List<Base_RoleEasy> _roles;
        public List<Base_RoleEasy> Roles
        {
            get { return _roles; }
            set
            {
                SetProperty(ref _roles, value);
            }
        }

        private ObservableCollection<Base_RoleEasy> _selectedRoles = new ObservableCollection<Base_RoleEasy>();
        public ObservableCollection<Base_RoleEasy> SelectedRoles
        {
            get { return _selectedRoles; }
            set
            {
                SetProperty(ref _selectedRoles, value);
            }
        }

        private List<Base_UserEasy> _users;
        public List<Base_UserEasy> Users
        {
            get { return _users; }
            set
            {
                SetProperty(ref _users, value);
            }
        }

        public OA_DefFormEditViewModel(OA_DefFormDTO data, string area, string identifier, string title = "编辑表单") : base(data, area, identifier, title, true)
        {
            if (Data == null)
            {
                InitData();
            }
            else
            {
                GetData(Data);
            }
        }

		protected override async void InitData()
		{
			Data = new OA_DefFormDTO();
            OAData = new OAData();
            FlowchartModel = new FlowchartModel();
            await GetTypes();
            await GetRoles();
            await GetUsers();
        }

        protected override async void GetData(OA_DefFormDTO para)
        {
            try
            {
                ShowWait();

                var result = await _dataProvider.GetData<OA_DefFormDTO>($"/OA_Manage/OA_DefForm/GetTheData?id={para.Id}");
                if (!result.IsOK)
                {
                    throw new Exception(result.ErrorMessage);
                }
                Data = result.ResponseItem;
                await GetTypes();
                await GetRoles();
                await GetUsers();

                OAData = Newtonsoft.Json.JsonConvert.DeserializeObject<OAData>(Data.WorkflowJSON);
                FlowchartModel model = new FlowchartModel();
                FlowChartHelper.G6ToFlowChart(OAData, model);
                FlowchartModel = model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                HideWait();
            }
        }   
        private async Task GetTypes()
        {
            var result = await _dataProvider.GetData<List<OA_DefTypeDTO>>($"/OA_Manage/OA_DefType/GetDataList?condition=Type&keyword=分类");
            if (!result.IsOK)
            {
                throw new Exception(result.ErrorMessage);
            }
            Types = result.ResponseItem;
        }

        private async Task GetRoles()
        {
            Roles = await _userData.GetAllRole();
            if (Data != null && Data.ValueRoles != null)
            {
                SelectedRoles = new ObservableCollection<Base_RoleEasy>(Roles.Where(p => Data.ValueRoles.Contains(p.Id)));
            }
        }

        private async Task GetUsers()
        {
            Users = await _userData.GetAllUser();
        }
    }
}
