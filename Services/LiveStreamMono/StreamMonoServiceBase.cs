﻿using System;
using System.Collections.Generic;
using System.Text;
using BorisGangBot_Mk2.Models;
using Discord;
using Discord.WebSocket;
using TwitchLib.Api.Interfaces;

namespace BorisGangBot_Mk2.Services.LiveStreamMono
{
    public abstract class StreamMonoServiceBase
    {
        private int _updint;
        private List<string> _streamlist;

        // Twitch API
        public ITwitchAPI TwAPI { get; protected set; }

        // Timer Update Interval in milliseconds
        public int UpdInt
        {
            get { return _updint; }
            set { _updint = value * 1000; }
        }

        // List of Streamers by UserLogin
        public List<string> StreamList
        {
            get { return _streamlist; }
            set { _streamlist = value; }
        }

        public List<StreamModel> StreamModels { get; set; }

        public List<EmbedBuilder> StreamEmbeds { get; set; }

        public List<SocketTextChannel> StreamNotifChannels = new List<SocketTextChannel>();
    }
}
