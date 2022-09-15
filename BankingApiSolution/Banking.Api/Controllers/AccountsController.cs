using Banking.Api.Domain;
using Banking.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers;

public class AccountsController : ControllerBase
{
    private readonly AccountManager _accountManager;

    public AccountsController(AccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    // GET /accounts

    [HttpGet("/accounts")]
    public async Task<ActionResult> GetAllAccounts()
    {
        //var response = new CollectionResponse<AccountSummaryResponse>
        //{
        //    Data = new List<AccountSummaryResponse>
        //    {
        //        new AccountSummaryResponse {Id = "1", Name= "Bob Smith"},
        //        new AccountSummaryResponse {Id = "2", Name= "Jill Jones"}
        //    }
        //};
        CollectionResponse<AccountSummaryResponse> response = response = await _accountManager.GetAllAccountsAsync();
        return Ok(response); // return a 200 Ok status code.
    }

    // GET /accounts
    [HttpGet("/accounts/{id}", Name = "get-account-by-id")]
    public async Task<ActionResult> GetAccountById(string id)
    {
        //var response = new AccountSummaryResponse { Id = id, Name = "Bob Smith" };
        AccountSummaryResponse response = await _accountManager.GetAccountByIdAsync(id);

        if(response is null)
        {
            return NotFound();
        }
        else
        {
            return Ok(response);
        }
        
    }
    [HttpPost("/accounts")]
    public async Task<ActionResult> AddAnAccount([FromBody] AccountCreateRequest request)
    {
        //validate it
        // if bad, return 400
        // save it to the databaser or whatever
        // return a 201 Created status code
        // return a location header with the URI of the brand new thing (account)
        // and give them a copy of what they would get if they did a request on that location header.

        //var response = new AccountSummaryResponse
        //{
        //    Id = Guid.NewGuid().ToString(),
        //    Name = request.Name

        //};

        AccountSummaryResponse response = await _accountManager.CreateAccountAsync(request);

        return CreatedAtRoute("get-account-by-id", new { id = response.Id }, response);
    }
}
