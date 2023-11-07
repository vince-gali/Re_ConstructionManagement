namespace Re_ConstructionManagement.Models;

public class Project 
{
    public int Id {get; set;}
    public string CompanyId {get; set;}
    public string Cost {get; set;}
    //REVIEW - make status an enum??
    //STUB - add additional ? to line above to get examples from blackbox 
    public string Status {get; set;}
    public string CompletionDate {get; set;}

    public string CreatorId {get; set;}
}

