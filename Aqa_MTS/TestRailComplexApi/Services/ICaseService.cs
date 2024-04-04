using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface ICaseService
{
    Task<Case> AddCase(string sectionId, Case newCase);
    Task<Case> GetCase(string caseId);
    Task<Case> UpdateCase(Case caseUpdate, string idCase);
    HttpStatusCode DeleteCase(string caseId);
    HttpStatusCode MoveCaseToSection (string sectionId, string newSectionId, string caseId);
}