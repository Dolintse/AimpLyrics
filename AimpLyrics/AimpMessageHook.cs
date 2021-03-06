﻿using Aimp4.Api;
using System;

namespace AimpLyrics
{
    public class AimpMessageHook : IAIMPMessageHook
    {
        public event Action FileInfoReceived;
        public event Action PlayerStopped;
        public event Action PlayerLoaded;

        public void CoreMessage(AIMPMessage message, int param1, IntPtr param2, ref IntPtr result)
        {
            switch (message)
            {
                case AIMPMessage.EventPlayableFileInfo:
                    FileInfoReceived?.Invoke();
                    break;
                case AIMPMessage.EventPlayerState when param1 == 0:
                    PlayerStopped?.Invoke();
                    break;
                case AIMPMessage.EventLoaded:
                    PlayerLoaded?.Invoke();
                    break;
            }
        }
    }
}
