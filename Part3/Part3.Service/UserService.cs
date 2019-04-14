﻿using part3.data.DAL;
using part3.data.Entities;
using Part3.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3.Service
{
    public class UserService
    {
        public User LoginByCredential(string username, string password)
        {
            UserDAL userDAL = new UserDAL();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                return null;
            }

            var user = userDAL.GetByUsername(username);
            if (user == null)
            {
                return null;
            }

            var passwordSalt = user.PasswordSalt;
            var passwordEncrypt = PasswordHash.EncryptionPasswordWithSalt(password, passwordSalt);
            if (passwordEncrypt == user.PasswordEncrypted)
            {
                return user;
            }
            else
            {
                return null;
            }

        }
    }
}
