﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroupRepository : IPageGroupRepository
    {
        private MyCmsContext db;
        public PageGroupRepository(MyCmsContext Context) { this.db = Context; }

        public IEnumerable<PageGroup> GetAllGroup()
        {
            return db.PageGroups;
        }
        public PageGroup GetGroupById(int GroupId)
        {
            return db.PageGroups.Find(GroupId);
        }
        public bool InsertGroup(PageGroup pageGroup)
        {
            try
            {
                db.PageGroups.Add(pageGroup);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteGroup(PageGroup pageGroup)
        {
            try
            {
                db.Entry(pageGroup).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteGroup(int groupId)
        {
            try
            {
                var group = GetGroupById(groupId);
                DeleteGroup(group);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<ShowGroupViewModel> GetGroupsForView()
        {
            return db.PageGroups.Select(g => new ShowGroupViewModel()
            {
                GroupID = g.GroupId,
                GroupTitle = g.GroupTitle,
                PageCount = g.Pages.Count
            });
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
