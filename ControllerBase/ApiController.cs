using Microsoft.AspNetCore.Mvc;
using SS.ServiceResult.ResultModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SS.ServiceResult.ControllerBase
{
    [ApiController]
    public class ApiController: Microsoft.AspNetCore.Mvc.ControllerBase
    {
        public IActionResult ServiceResult<T>(ServiceResult<T> source)
        {
            if (source.Success)
            {
                return Ok(source.Result);
            }
            else
            {
                return StatusCode(source.Error.StatusCode, source.Error);
            }
        }

        public IActionResult ServiceResult(ResultModels.ServiceResult source)
        {
            if (source.Success)
            {
                return Ok();
            }
            else
            {
                return StatusCode(source.Error.StatusCode, source.Error);
            }
        }
    }
}
