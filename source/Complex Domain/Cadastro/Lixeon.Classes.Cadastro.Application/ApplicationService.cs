using Lixeon.Classes.Core.Data.Interfaces;
using Lixeon.Classes.Core.Domain.Events;
using Lixeon.Classes.Core.Domain.Interfaces;
using System;

namespace Lixeon.Classes.Cadastro.Application
{
    public class ApplicationService
    {
        private readonly IUnitOfWork _unitOfWork;
        protected readonly IHandler<DomainNotification> Notifications;
        //protected AlunoCadastradoHandler AlunoCadastradoHandler;

        public ApplicationService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this.Notifications = DomainEvent.Container.GetInstance<IHandler<DomainNotification>>();
            //this.AlunoCadastradoHandler = DomainEvent.Container.GetInstance<AlunoCadastradoHandler>();
        }

        public bool Commit()
        {
            if (Notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}
