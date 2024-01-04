using System;
using System.Collections.Generic;
using Oqtane.Models;

namespace Oqtane.UI
{
    public class PageState
    {
        public Alias Alias { get; set; }
        public Site Site { get; set; }
        public Page Page { get; set; }
        public User User { get; set; }
        public Uri Uri { get; set; }
        public Route Route { get; set; }
        public Dictionary<string, string> QueryString { get; set; }
        public string UrlParameters { get; set; }
        public int ModuleId { get; set; }
        public string Action { get; set; }
        public bool EditMode { get; set; }
        public DateTime LastSyncDate { get; set; }
        public Shared.Runtime Runtime { get; set; }
        public int VisitorId { get; set; }
        public string RemoteIPAddress { get; set; }
        public string ReturnUrl { get; set; }
        public bool IsInternalNavigation { get; set; }

        public List<Page> Pages
        {
            get { return Site.Pages; }
        }
        public List<Module> Modules
        {
            get { return Site.Modules; }
        }
        public List<Language> Languages
        {
            get { return Site.Languages; }
        }


        // determines if the PageState matches the ModuleState for component rendering purposes
        public bool RenderModuleInstance(Module ModuleState)
        {
            return Page.PageId == ModuleState.PageId && (ModuleId == -1 || ModuleId == ModuleState.ModuleId) && Action == ModuleState.Action;
        }
    }
}
