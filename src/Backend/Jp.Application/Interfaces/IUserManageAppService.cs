﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Jp.Application.EventSourcedNormalizers;
using Jp.Application.ViewModels;
using Jp.Application.ViewModels.UserViewModels;
using Jp.Domain.Models;

namespace Jp.Application.Interfaces
{
    public interface IUserManageAppService : IDisposable
    {
        Task UpdateProfile(UserViewModel model);
        Task UpdateProfilePicture(ProfilePictureViewModel model);
        Task ChangePassword(ChangePasswordViewModel model);
        Task CreatePassword(SetPasswordViewModel model);
        Task RemoveAccount(RemoveAccountViewModel model);
        Task<bool> HasPassword(Guid userId);
        IEnumerable<EventHistoryData> GetHistoryLogs(Guid value);
        Task<IEnumerable<UserListViewModel>> GetUsers();
        Task<UserViewModel> GetUserDetails(string username);
        Task<UserViewModel> GetUserAsync(Guid value);
        Task UpdateUser(UserViewModel model);

        Task<IEnumerable<ClaimViewModel>> GetClaims(string userName);
        Task SaveClaim(SaveUserClaimViewModel model);
        Task RemoveClaim(RemoveUserClaimViewModel model);
        Task<IEnumerable<RoleViewModel>> GetRoles(string userName);
        Task RemoveRole(RemoveUserRoleViewModel model);
        Task SaveRole(SaveUserRoleViewModel model);
        Task<IEnumerable<UserLoginViewModel>> GetLogins(string userName);
        Task RemoveLogin(RemoveUserLoginViewModel model);
    }
}
