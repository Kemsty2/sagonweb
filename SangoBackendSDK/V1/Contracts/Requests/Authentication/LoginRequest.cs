﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SangonBackendSDK.V1.Contracts.Requests.Authentication
{
    public class LoginRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
