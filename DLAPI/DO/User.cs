﻿namespace DO
{
    public class User
    {
        public string UserName { get; set; }//users Name
        public int Password { get; set; }//user password
        public bool AllowingAccess { get; set; }//User access
        public bool DelUser { get; set; }//User delete field (no actual deletion)
    }
}