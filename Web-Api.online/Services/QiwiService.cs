﻿using Dapper;
using Microsoft.Build.Evaluation;
using Microsoft.Extensions.Configuration.UserSecrets;
using Nethereum.ABI.Util;
using Nethereum.Contracts.QueryHandlers.MultiCall;
using System;
using System.Data;
using System.Threading.Tasks;
using Web_Api.online.Clients.Models;
using Web_Api.online.Data.Repositories;
using Web_Api.online.Data.Repositories.Abstract;
using Web_Api.online.Models;
using Web_Api.online.Models.Enums;
using Web_Api.online.Models.Tables;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Web_Api.online.Services
{
    public class QiwiService
    {
        private QiwiRepository _qiwiRepository;
        private UserRepository _userRepository;
        private WalletsRepository _walletsRepository;
        private EventsRepository _eventsRepository;
        private ExceptionsRepository _exceptionsRepository;
        private WalletService _walletService;

        public QiwiService(
            QiwiRepository qiwiRepository,
            UserRepository userRepository,
            WalletsRepository walletsRepository,
            EventsRepository eventsRepository,
            ExceptionsRepository exceptionsRepository,
            WalletService walletService
            )
        {
            _qiwiRepository = qiwiRepository;
            _userRepository = userRepository;
            _walletsRepository = walletsRepository;
            _eventsRepository = eventsRepository;
            _exceptionsRepository = exceptionsRepository;
            _walletService = walletService;
        }

        public async Task<Phones> GetQiwiAcoount(string number)
        {
            return await _qiwiRepository.GetQiwiAcoount(number);
        }

        public async Task QiwiHistoryChecked(string number)
        {
            await _qiwiRepository.QiwiHistoryChecked(number);
        }

        public async Task<Phones> GetQiwiAcoountCashOut(double amount)
        {
            var result = await _qiwiRepository.GetQiwiAcoountCashOut(amount);

            return result;
        }
    }
}
