﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IPageGroupRepository : IDisposable
    {
        IEnumerable<PageGroup> GetAllGroup();
        PageGroup GetGroupById(int GroupId);

        bool InsertGroup(PageGroup pageGroup);

        bool UpdateGroup(PageGroup pageGroup);
        bool DeleteGroup(PageGroup pageGroup);
        bool DeleteGroup(int groupId);

        void Save();

        IEnumerable<ShowGroupViewModel> GetGroupsForView();
    }
}
