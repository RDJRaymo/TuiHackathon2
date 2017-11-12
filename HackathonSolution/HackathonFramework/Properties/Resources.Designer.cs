﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HackathonFramework.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HackathonFramework.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Booking
        ///WHERE CabinID = @cabinID.
        /// </summary>
        internal static string Bookings_GetByCabinID {
            get {
                return ResourceManager.GetString("Bookings_GetByCabinID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT Itinerary, Name FROM Itinerary
        ///ORDER BY ItineraryID ASC;.
        /// </summary>
        internal static string Itinerary_ListAll {
            get {
                return ResourceManager.GetString("Itinerary_ListAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Passenger
        ///WHERE Name = @passengerName;.
        /// </summary>
        internal static string Passenger_GetByName {
            get {
                return ResourceManager.GetString("Passenger_GetByName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM Passenger
        ///ORDER BY Name;.
        /// </summary>
        internal static string Passenger_ListAll {
            get {
                return ResourceManager.GetString("Passenger_ListAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE Passenger
        ///SET Location = @location
        ///WHERE Name = @passengerName;.
        /// </summary>
        internal static string Passenger_UpdateLocation {
            get {
                return ResourceManager.GetString("Passenger_UpdateLocation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT port1.portID
        ///	,port2.portID
        ///	,st_distance_sphere(port1.location, port2.location) distance
        ///FROM port port1
        ///INNER JOIN port port2 ON port1.SeaportID &lt;&gt; port2.SeaportID
        ///	AND port2.SeaportID &gt; port1.SeaportID
        ///ORDER BY 1, 2;.
        /// </summary>
        internal static string Port_GetDistances {
            get {
                return ResourceManager.GetString("Port_GetDistances", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT portID, Name
        ///FROM port
        ///ORDER BY Name ASC;.
        /// </summary>
        internal static string Port_ListNameAndID {
            get {
                return ResourceManager.GetString("Port_ListNameAndID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to DELETE FROM PortOfCall
        ///WHERE ShipID = @shipID;.
        /// </summary>
        internal static string PortOfCall_ClearByShipID {
            get {
                return ResourceManager.GetString("PortOfCall_ClearByShipID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO PortOfCall(
        ///	ShipID,
        ///	portID
        ///)
        ///VALUES (
        ///	@shipID,
        ///	@portID
        ///).
        /// </summary>
        internal static string PortOfCall_Insert {
            get {
                return ResourceManager.GetString("PortOfCall_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT PortOfCall.*, Port.Name FROM PortOfCall
        ///INNER JOIN Port ON Port.PortID = PortOfCall.PortID
        ///WHERE ShipID = @shipID
        ///ORDER BY StopOrder ASC;.
        /// </summary>
        internal static string PortOfCall_ListByShipID {
            get {
                return ResourceManager.GetString("PortOfCall_ListByShipID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE PortOfCall
        ///SET StopOrder = @stopOrder
        ///WHERE ShipID = @shipID
        ///	AND PortID = @portID;.
        /// </summary>
        internal static string PortOfCall_Update {
            get {
                return ResourceManager.GetString("PortOfCall_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT ShipID, Name
        ///FROM Ship
        ///ORDER BY Name ASC;.
        /// </summary>
        internal static string Ship_ListNameAndID {
            get {
                return ResourceManager.GetString("Ship_ListNameAndID", resourceCulture);
            }
        }
    }
}
