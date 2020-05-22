namespace Here.Client.Responses.Incidents
{
    public class Json
    {
        public class Rootobject
        {
            public string TIMESTAMP { get; set; }
            public float VERSION { get; set; }
            public TRAFFICITEMS TRAFFICITEMS { get; set; }
        }

        public class TRAFFICITEMS
        {
            public TRAFFICITEM[] TRAFFICITEM { get; set; }
        }

        public class TRAFFICITEM
        {
            public long TRAFFICITEMID { get; set; }
            public long ORIGINALTRAFFICITEMID { get; set; }
            public string TRAFFICITEMSTATUSSHORTDESC { get; set; }
            public string TRAFFICITEMTYPEDESC { get; set; }
            public string STARTTIME { get; set; }
            public string ENDTIME { get; set; }
            public string ENTRYTIME { get; set; }
            public CRITICALITY CRITICALITY { get; set; }
            public bool VERIFIED { get; set; }
            public ABBREVIATION ABBREVIATION { get; set; }
            public RDSTMCLOCATIONS RDSTMCLOCATIONS { get; set; }
            public LOCATION LOCATION { get; set; }
            public TRAFFICITEMDETAIL TRAFFICITEMDETAIL { get; set; }
            public TRAFFICITEMDESCRIPTION[] TRAFFICITEMDESCRIPTION { get; set; }
        }

        public class CRITICALITY
        {
            public string ID { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class ABBREVIATION
        {
            public string SHORTDESC { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class RDSTMCLOCATIONS
        {
            public RDSTMC[] RDSTMC { get; set; }
        }

        public class RDSTMC
        {
            public ORIGIN ORIGIN { get; set; }
            public TO TO { get; set; }
            public string DIRECTION { get; set; }
            public ALERTC ALERTC { get; set; }
        }

        public class ORIGIN
        {
            public string EBUCOUNTRYCODE { get; set; }
            public int TABLEID { get; set; }
            public string LOCATIONID { get; set; }
            public string LOCATIONDESC { get; set; }
            public string RDSDIRECTION { get; set; }
        }

        public class TO
        {
            public string EBUCOUNTRYCODE { get; set; }
            public int TABLEID { get; set; }
            public string LOCATIONID { get; set; }
            public string LOCATIONDESC { get; set; }
            public string RDSDIRECTION { get; set; }
        }

        public class ALERTC
        {
            public int TRAFFICCODE { get; set; }
            public int QUANTIFIERS { get; set; }
            public string DESCRIPTION { get; set; }
            public string ALERTCDURATION { get; set; }
            public int ALERTCDIRECTION { get; set; }
            public int UPDATECLASS { get; set; }
            public string PHRASECODE { get; set; }
            public string EXTENT { get; set; }
            public int DURATION { get; set; }
        }

        public class LOCATION
        {
            public DEFINED DEFINED { get; set; }
            public GEOLOC GEOLOC { get; set; }
            public NAVTECH NAVTECH { get; set; }
            public INTERSECTION INTERSECTION { get; set; }
            public POLITICALBOUNDARY POLITICALBOUNDARY { get; set; }
        }

        public class DEFINED
        {
            public ORIGIN1 ORIGIN { get; set; }
            public TO1 TO { get; set; }
        }

        public class ORIGIN1
        {
            public ROADWAY ROADWAY { get; set; }
            public POINT POINT { get; set; }
            public DIRECTION DIRECTION { get; set; }
            public PROXIMITY PROXIMITY { get; set; }
        }

        public class ROADWAY
        {
            public DESCRIPTION[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class POINT
        {
            public DESCRIPTION1[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION1
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class DIRECTION
        {
            public DESCRIPTION2[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION2
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class PROXIMITY
        {
            public string ID { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class TO1
        {
            public ROADWAY1 ROADWAY { get; set; }
            public POINT1 POINT { get; set; }
            public DIRECTION1 DIRECTION { get; set; }
            public PROXIMITY1 PROXIMITY { get; set; }
        }

        public class ROADWAY1
        {
            public DESCRIPTION3[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION3
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class POINT1
        {
            public DESCRIPTION4[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION4
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class DIRECTION1
        {
            public DESCRIPTION5[] DESCRIPTION { get; set; }
            public int ID { get; set; }
        }

        public class DESCRIPTION5
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }

        public class PROXIMITY1
        {
            public string ID { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class GEOLOC
        {
            public ORIGIN2 ORIGIN { get; set; }
            public TO2[] TO { get; set; }
        }

        public class ORIGIN2
        {
            public float LATITUDE { get; set; }
            public float LONGITUDE { get; set; }
        }

        public class TO2
        {
            public float LATITUDE { get; set; }
            public float LONGITUDE { get; set; }
        }

        public class NAVTECH
        {
            public EDGE EDGE { get; set; }
            public string VERSIONID { get; set; }
        }

        public class EDGE
        {
            public string[] EDGEID { get; set; }
        }

        public class INTERSECTION
        {
            public ORIGIN3 ORIGIN { get; set; }
            public TO3 TO { get; set; }
        }

        public class ORIGIN3
        {
            public string ID { get; set; }
            public STREET1 STREET1 { get; set; }
            public STREET2 STREET2 { get; set; }
            public string COUNTY { get; set; }
            public string STATE { get; set; }
            public PROXIMITY2 PROXIMITY { get; set; }
        }

        public class STREET1
        {
            public string ADDRESS1 { get; set; }
        }

        public class STREET2
        {
            public string ADDRESS1 { get; set; }
        }

        public class PROXIMITY2
        {
            public string ID { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class TO3
        {
            public string ID { get; set; }
            public STREET11 STREET1 { get; set; }
            public STREET21 STREET2 { get; set; }
            public string COUNTY { get; set; }
            public string STATE { get; set; }
            public PROXIMITY3 PROXIMITY { get; set; }
        }

        public class STREET11
        {
            public string ADDRESS1 { get; set; }
        }

        public class STREET21
        {
            public string ADDRESS1 { get; set; }
        }

        public class PROXIMITY3
        {
            public string ID { get; set; }
            public string DESCRIPTION { get; set; }
        }

        public class POLITICALBOUNDARY
        {
            public METROAREA METROAREA { get; set; }
            public string COUNTY { get; set; }
            public MUNICIPALITY MUNICIPALITY { get; set; }
        }

        public class METROAREA
        {
            public string value { get; set; }
            public int ID { get; set; }
        }

        public class MUNICIPALITY
        {
            public string NAME { get; set; }
        }

        public class TRAFFICITEMDETAIL
        {
            public bool ROADCLOSED { get; set; }
            public EVENT EVENT { get; set; }
        }

        public class EVENT
        {
            public bool EVENTITEMCANCELLED { get; set; }
            public SCHEDULEDCONSTRUCTIONEVENT SCHEDULEDCONSTRUCTIONEVENT { get; set; }
        }

        public class SCHEDULEDCONSTRUCTIONEVENT
        {
            public string SCHEDULEDCONSTRUCTIONTYPEDESC { get; set; }
            public string SCHEDULEDCONSTRUCTIONDETAIL { get; set; }
        }

        public class TRAFFICITEMDESCRIPTION
        {
            public string content { get; set; }
            public string TYPE { get; set; }
        }
    }
}