﻿using System;
using System.Collections.Generic;
using System.Text;
using wojilu.Common.AppBase;

namespace wojilu.Web.Controller.Content.Admin.Section {

    public class NullSectionAdmin : IPageAdminSection {

        public void AdminSectionShow( int sectionId ) {

        }

        public List<IPageSettingLink> GetSettingLink( int sectionId ) {
            return new List<IPageSettingLink>();
        }

        public string GetEditLink( int postId ) {
            return "#";
        }

        public string GetSectionIcon( int sectionId ) {
            return "";
        }

    }
}
