﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace HCMIS.Desktop.Reports.Finance
{
    public partial class CostTierPriceList : DevExpress.XtraReports.UI.XtraReport
    {
        public CostTierPriceList(string userFullName)
        {
            InitializeComponent();
            PrintUserDetailOnReport(userFullName);
            pxLogo.ImageUrl = BLL.GeneralInfo.Current.LogoUrl;
        }

        private void PrintUserDetailOnReport(string userFullName)
        {
            PrintedBy.Text = string.Format("Printed by {0} on {1} , HCMIS {2}", userFullName,
                                                         BLL.DateTimeHelper.ServerDateTime, System.Reflection.Assembly.GetExecutingAssembly().GetName().Version);
        }

    }
}
