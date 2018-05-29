﻿
using Smod2.API;
using Smod2.Events.Admin;

namespace Smod2.Events
{
	public enum AuthType
	{
		PASSWORD,
		STAFF,
		PROJECT_MANAGMENT
	}
	public interface IEventHandlerAdminQuery : IEventHandler
	{
		void OnAdminQuery(AdminQueryEvent ev);
	}
	public interface IEventHandlerAuthCheck : IEventHandler
	{
		void OnAuthCheck(AuthCheckEvent ev);
	}
	public interface IEventHandlerBan : IEventHandler
	{
		void OnBan(BanEvent ev);
	}
}
