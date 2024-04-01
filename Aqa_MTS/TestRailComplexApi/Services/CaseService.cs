﻿using System.Net;
using RestSharp;
using TestRailComplexApi.Clients;
using TestRailComplexApi.Models;

namespace TestRailComplexApi.Services;

public class CaseService : ICaseService, IDisposable
{
    private readonly RestClientExtended _client;
    
    public CaseService(RestClientExtended client)
    {
        _client = client;
    }
    
    public Task<Case> AddCase(string sectionId, Case newCase)
    {
        var request = new RestRequest("index.php?/api/v2/add_case/{section_id}", Method.Post)
            .AddUrlSegment("section_id", sectionId)
            .AddJsonBody(newCase);

        return _client.ExecuteAsync<Case>(request);
    }
    
    public Task<Case> GetCase(string caseId)
    {
        var request = new RestRequest("index.php?/api/v2/get_case/{case_id}")
            .AddUrlSegment("case_id", caseId);
        
        return _client.ExecuteAsync<Case>(request);
    }

    public Task<Case> UpdateCase(Case caseUpdate, string idCase)
    {
        var request = new RestRequest("index.php?/api/v2/update_case/{case_id}", Method.Post)
            .AddUrlSegment("case_id", idCase)
            .AddJsonBody(caseUpdate);
        
        return _client.ExecuteAsync<Case>(request);
    }

    public HttpStatusCode DeleteCase(string caseId)
    {
        var request = new RestRequest("index.php?/api/v2/delete_case/{case_id}", Method.Post)
            .AddUrlSegment("case_id", caseId)
            .AddJsonBody("{}");
        
        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public HttpStatusCode MoveCaseToSection(string sectionId)
    {
        var request = new RestRequest("index.php?/api/v2/move_cases_to_section/{section_id}", Method.Post)
            .AddUrlSegment("section_id", sectionId)
            .AddJsonBody("{}");
        
        return _client.ExecuteAsync(request).Result.StatusCode;
    }

    public void Dispose()
    {
        _client?.Dispose();
        GC.SuppressFinalize(this);
    }
}