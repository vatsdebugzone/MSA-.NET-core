using Microsoft.AspNetCore.Mvc;
using ProductAPI.DTO;

namespace ProductAPI.Helpers
{
    public static class ResponseHelper
    {
        public static IActionResult ToApiResponse<T>(this ControllerBase controller, T result)
        {
            var response = new ResponseDto<T>
            {
                IsSuccess = true,
                Result = result
            };
            return controller.Ok(response);
        }

        public static IActionResult ToApiErrorResponse(this ControllerBase controller, string errorMessage)
        {
            var response = new ResponseDto<string>
            {
                IsSuccess = false,
                Errors = errorMessage.Split('\u002C').ToList()
            };
            return controller.BadRequest(response);
        }
    }   
}
