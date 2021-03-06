﻿using WebShop.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Messaging
{
    public interface ICommandHandler<TCommand>:IMessageHandler<TCommand> where TCommand:ICommand
    {
    }
}
