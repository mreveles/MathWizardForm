using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MathWizardForm.Models;

namespace MathWizardForm.Models {
    public static class Repository {
        private static List<UserResponse> responses = new List<UserResponse>();

        public static IEnumerable<UserResponse> Responses {
            get {
                return responses;
            }
        }

        public static void AddResponse(UserResponse response) {
            responses.Add(response);
        }
    }
}
