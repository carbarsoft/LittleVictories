﻿using LittleVictories.Models;

namespace LittleVictories.Services
{
    public interface IDeviceInstallationService
    {
        string Token { get; set; }
        bool NotificationsSupported { get; }
        string GetDeviceId();
        DeviceInstallation GetDeviceInstallation(params string[] tags);
    }
}
