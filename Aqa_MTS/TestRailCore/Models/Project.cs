namespace TestRailCore.Models;

public class Project
{
    public string NameInput { get; set; }
    public string AnnouncementInput { get; set; }
    public bool ShowAnnouncementCheckbox { get; set; }
    public int ProjectTypeRadio { get; set; }
    public bool CaseApprovalsCheckbox { get; set; }
}