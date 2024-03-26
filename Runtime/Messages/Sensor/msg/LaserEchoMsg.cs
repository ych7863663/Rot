//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Sensor
{
    [Serializable]
    public class LaserEchoMsg : Message
    {
        public const string k_RosMessageName = "sensor_msgs/LaserEcho";
        public override string RosMessageName => k_RosMessageName;

        //  This message is a submessage of MultiEchoLaserScan and is not intended
        //  to be used separately.
        public float[] echoes;
        //  Multiple values of ranges or intensities.
        //  Each array represents data from the same angle increment.

        public LaserEchoMsg()
        {
            this.echoes = new float[0];
        }

        public LaserEchoMsg(float[] echoes)
        {
            this.echoes = echoes;
        }

        public static LaserEchoMsg Deserialize(MessageDeserializer deserializer) => new LaserEchoMsg(deserializer);

        private LaserEchoMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.echoes, sizeof(float), deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.WriteLength(this.echoes);
            serializer.Write(this.echoes);
        }

        public override string ToString()
        {
            return "LaserEchoMsg: " +
            "\nechoes: " + System.String.Join(", ", echoes.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
