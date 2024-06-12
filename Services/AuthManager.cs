﻿using AutoMapper;
using Entities.Dtos;
using Microsoft.AspNetCore.Identity;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class AuthManager : IAuthService
	{
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly UserManager<IdentityUser> _userManager;
		private readonly IMapper _mapper;

		public AuthManager(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager, IMapper mapper)
		{
			_roleManager = roleManager;
			_userManager = userManager;
			_mapper = mapper;
		}

		public IEnumerable<IdentityRole> Roles => 
			_roleManager.Roles;

		public async Task<IdentityResult> CreateUser(UserDtoForCreation userDto)
		{
			var user = _mapper.Map<IdentityUser>(userDto);
			var result = await _userManager.CreateAsync(user, userDto.Password);


			if (!result.Succeeded)
				throw new Exception("Kullanıcı oluşturulamadı.");
			if(userDto.Roles.Count >0)
			{
				var roleResult = await _userManager.AddToRolesAsync(user, userDto.Roles);
				if (roleResult.Succeeded)
					throw new Exception("Sistemin rollerle ilgili sorunları var.");
			}
			return result;	
		}

		public IEnumerable<IdentityUser> GetAllUsers()
		{
			return _userManager.Users.ToList();
		}

		public async Task<IdentityUser> GetOneUser(string userName)
		{
			return await _userManager.FindByNameAsync(userName);
		}

		public async Task Update(UserDtoForUpdate userDto)
		{
			var user = await GetOneUser(userDto.UserName);
			user.PhoneNumber = userDto.PhoneNumber;
			user.Email = userDto.Email;

			if(user is not null) 
			{
				var result = await _userManager.UpdateAsync(user);
			}

			if(userDto.Roles.Count > 0)
			{
				var userRoles = await _userManager.GetRolesAsync(user);
				var r1 = await _userManager.RemoveFromRoleAsync(user, userRoles);
				var r2 = await _userManager.AddToRoleAsync(user,userDto.Roles);
			}
			return;
		}
	}
}
