// <copyright file="StatsManager.cs" company="Google Inc.">
// Copyright (C) 2015 Google Inc.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>

#if (UNITY_ANDROID || (UNITY_IPHONE && !NO_GPGS))

namespace GooglePlayGames.Native.Cwrapper
{
    using System;
    using System.Runtime.InteropServices;

    internal static class StatsManager
    {
        internal delegate void FetchForPlayerCallback (
        /* from(StatsManager_FetchForPlayerResponse_t) */ IntPtr arg0,
        /* from(void *) */ IntPtr arg1);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern void StatsManager_FetchForPlayer (
            HandleRef self,
        /* from(DataSource_t) */Types.DataSource data_source,
        /* from(StatsManager_FetchForPlayerCallback_t) */FetchForPlayerCallback callback,
        /* from(void *) */IntPtr callback_arg);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern void StatsManager_FetchForPlayerResponse_Dispose (
            HandleRef self);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern /* from(ResponseStatus_t) */ CommonErrorStatus.ResponseStatus StatsManager_FetchForPlayerResponse_GetStatus (
            HandleRef self);

        [DllImport(SymbolLocation.NativeSymbolLocation)]
        internal static extern /* from(PlayerStats_t) */ IntPtr StatsManager_FetchForPlayerResponse_GetData (
            HandleRef self);
    }
}
#endif // (UNITY_ANDROID || UNITY_IPHONE)