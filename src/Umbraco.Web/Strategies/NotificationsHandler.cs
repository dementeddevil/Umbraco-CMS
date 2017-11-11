using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Core.Models.EntityBase;
using Umbraco.Core.Services;
using umbraco.BusinessLogic.Actions;
using Umbraco.Core.Models;

namespace Umbraco.Web.Strategies
{
    /// <summary>
    /// Subscribes to the relavent events in order to send out notifications
    /// </summary>
    public sealed class NotificationsHandler : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            base.ApplicationStarted(umbracoApplication, applicationContext);

            ContentService.SentToPublish += (sender, args) =>
                applicationContext.Services.NotificationService.SendNotification(
                    args.Entity, ActionToPublish.Instance, applicationContext);

            //Send notifications for the published action
            ContentService.Published +=
                (sender, args) =>
                {
                    foreach (var content in args.PublishedEntities)
                    {
                        applicationContext.Services.NotificationService.SendNotification(
                            content, ActionPublish.Instance, applicationContext);
                    }
                };

            //Send notifications for the update and created actions
            ContentService.Saved +=
                (sender, args) =>
                {
                    var newEntities = new List<IContent>();
                    var updatedEntities = new List<IContent>();

                    //need to determine if this is updating or if it is new
                    foreach (var entity in args.SavedEntities)
                    {
                        var dirty = (IRememberBeingDirty)entity;
                        if (dirty.WasPropertyDirty("Id"))
                        {
                            //it's new
                            newEntities.Add(entity);
                        }
                        else
                        {
                            //it's updating
                            updatedEntities.Add(entity);
                        }
                    }

                    applicationContext.Services.NotificationService.SendNotification(
                        newEntities, ActionNew.Instance, applicationContext);
                    applicationContext.Services.NotificationService.SendNotification(
                        updatedEntities, ActionUpdate.Instance, applicationContext);
                };

            //Send notifications for the delete action
            ContentService.Deleted +=
                (sender, args) =>
                {
                    foreach (var content in args.DeletedEntities)
                    {
                        applicationContext.Services.NotificationService.SendNotification(
                            content, ActionDelete.Instance, applicationContext);
                    }
                };

            //Send notifications for the unpublish action
            ContentService.UnPublished +=
                (sender, args) =>
                {
                    foreach (var content in args.PublishedEntities)
                    {
                        applicationContext.Services.NotificationService.SendNotification(
                            content, ActionUnPublish.Instance, applicationContext);
                    }
                };
        }
    }
}
