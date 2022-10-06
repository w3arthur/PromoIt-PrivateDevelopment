﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using PromotItLibrary.Interfaces;
using PromotItLibrary.Models;
using PromotItLibrary.Patterns;
using PromotItLibrary.Patterns.Actions;
using PromotItLibrary.Patterns.LinkedLists;
using PromotItLibrary.Patterns.LinkedLists.LinkedList_Function_State.LinkedLists_Interfaces;

namespace PromotItLibrary.Classes
{
    public class AdminUser : Users, IAdminUser, ILinkeListUser_Admin
    {
        public AdminUser() : base() {
            UserType = "admin";
            actionsUser = new ActionsUser(this, mySQL, httpClient);
            linkeListUser = new LinkeListUser_Admin(this, mySQL, httpClient);
            dataTableUser = new DataTableUser(this);

        }
        public AdminUser(Users user) : base(user) {
            UserType = "admin";
            actionsUser = new ActionsUser(this, mySQL, httpClient);
            linkeListUser = new LinkeListUser_Admin(this, mySQL, httpClient);
            dataTableUser = new DataTableUser(this);
        }

        //LinkedList and DataTable
        public async Task<List<Users>> MySQL_GetAllUsers_ListAsync(Modes mode = null) =>
            await linkeListUser.MySQL_GetAllUsers_ListAsync(mode);
        public async Task<DataTable> GetAllUsers_DataTableAsync() =>
            await dataTableUser.GetAllUsers_DataTableAsync();
        public async Task<DataTable> GetAllCampaignsAdmin_DataTableAsync() =>
            await dataTableUser.GetAllCampaignsAdmin_DataTableAsync();

    }
}
