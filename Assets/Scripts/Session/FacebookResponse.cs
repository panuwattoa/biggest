﻿/**
 * Copyright 2019 The Knights Of Unity, created by Pawel Stolarczyk
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


namespace Scripts.Session
{

    /// <summary>
    /// Response received after Facebool linking attempt
    /// </summary>
    public enum FacebookResponse
    {
        /// <summary>
        /// Facebook account was successfully linked to Nakama account.
        /// </summary>
        Linked,

        /// <summary>
        /// An error has occured linking Facebook account.
        /// </summary>
        Error,

        /// <summary>
        /// Facebook linking was cancelled by user.
        /// </summary>
        Cancelled,

        /// <summary>
        /// Given Facebook account is already linked to another Nakama account.
        /// </summary>
        Conflict,

        /// <summary>
        /// Method <see cref="NakamaSessionManager.InitializeFacebook(System.Action, System.Action)"/>
        /// has not been called.
        /// </summary>
        NotInitialized
    }

}