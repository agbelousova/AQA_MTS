using System.Net;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public interface ICaseService
{
    Task<Case> GetCase(string caseId);
    Task<Case> UpdateCase(Case caseUpdate);
    HttpStatusCode DeleteCase(string caseId);
    HttpStatusCode MoveCaseToSection (string sectionId);
}