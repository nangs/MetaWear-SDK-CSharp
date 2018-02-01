﻿using MbientLab.MetaWear.Builder;

namespace MbientLab.MetaWear {
    /// <summary>
    /// Defines how data flows from a data producer to an endpoint
    /// </summary>
    public interface IRoute {
        /// <summary>
        /// Unique value identifying the route.  
        /// <para>Use with <see cref="IMetaWearBoard.LookupRoute(uint)"/> to retrive an existing route</para>
        /// </summary>
        uint ID { get; }
        /// <summary>
        /// True if this object is still useable, discard if false
        /// </summary>
        bool Valid { get; }
        /// <summary>
        /// Array data subscribers associated with the <see cref="IRouteComponent.Stream(System.Action{IData})"/> and <see cref="IRouteComponent.Log()"/> components.
        /// <para>
        /// The array is ordered to match the order in which the <code>Stream</code> and <code>Log</code> components 
        /// are added in the route builder
        /// </para>
        /// </summary>
        ISubscriber[] Subscribers { get; }

        /// <summary>
        /// Removes the route and marks the object as invalid
        /// </summary>
        void Remove();
    }
}
