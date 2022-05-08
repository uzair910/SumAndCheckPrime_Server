using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

[Route("api/[controller]")]
[ApiController]
public class MyAPIController : ControllerBase
{
    // GET api/values
    //[EnableCors()]
    [HttpGet]
    public ActionResult Get(ActionType action, string sNumbers, int iNumber)
    {
        try
        {
            switch (action)
            {
                case ActionType.sumandcheck:
                    iNumber = sNumbers.GetSpecialSum();
                    return Ok(new { result = iNumber, isPrime = iNumber.IsPrime() });
                case ActionType.checkprime:
                    return Ok(new { isPrime = iNumber.IsPrime() });
            }
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
        return BadRequest();
    }
}

public enum ActionType
{
    sumandcheck,
    checkprime
}
