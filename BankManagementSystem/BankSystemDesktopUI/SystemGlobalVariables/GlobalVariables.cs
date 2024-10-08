﻿using BankSystemBusiness;
using System;

namespace SystemGlobalVariables
{
    static public class GlobalVariables
    {

        public static User CurrentUser = User.Find(null, null);
        [Flags]
        public enum enMainMenuPermission { AddClient = 1, FindClient = 2, DeleteClient = 4, UpdateClient = 8, ShowClients = 16, ManageUsers = 32, LoginRegister = 64, Transaction = 128, Transfers = 256 };

        public static bool CheckAccessPermission(GlobalVariables.enMainMenuPermission menuPermission)
        {
            if (GlobalVariables.CurrentUser.Permission == -1)
            {
                return true;
            }

            return (((int)menuPermission & GlobalVariables.CurrentUser.Permission) == (int)menuPermission);
        }

        public static bool CheckAccessPermission(int Permission_User, GlobalVariables.enMainMenuPermission menuPermission)
        {
            if (GlobalVariables.CurrentUser.Permission == -1)
            {
                return true;
            }

            return (((int)menuPermission & Permission_User) == (int)menuPermission);
        }

        public static DateTime DateLoginToSystem;

        public static DateTime DateLogoutFromSystem;

    }
}
