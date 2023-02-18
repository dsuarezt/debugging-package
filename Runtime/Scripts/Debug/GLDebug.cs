//-----------------------------------------------------------------------
// <copyright file="GLDebug.cs" company="Giving Life Studio">
//   <author>Dayron Suárez del Toro</author>
//   <date>February 18, 2023</date>
//   Copyright© 2023 Giving Life Studio. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

using UnityEngine;

namespace GivingLife.Debugging
{
    /// <summary>
    /// This class is an improved version of UnityEngine.Debug that uses Conditional attribute.
    /// </summary>
    public class GLDebug : MonoBehaviour
    {
        #region Constants

        public const string LOGGING_DIRECTIVE = "LOGGING";

        #endregion

        #region Methods

        /// <summary>
        /// Logs a message.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void Log(object message, Object context = null)
        {
            Debug.Log(message, context);
        }

        /// <summary>
        /// Logs a message with a specific color.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Text message color.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void Log(object message, Color color, Object context = null)
        {
#if UNITY_EDITOR
            message = GetColoredMessage(message, color);
#endif
            Debug.Log(message, context);
        }

        /// <summary>
        /// Logs a formated message.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogFormat(string format, params object[] args)
        {
            Debug.LogFormat(format, args);
        }

        /// <summary>
        /// Logs a formated message.
        /// </summary>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogFormat(Object context, string format, params object[] args)
        {
            Debug.LogFormat(context, format, args);
        }

        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogError(object message, Object context = null)
        {
            Debug.LogError(message, context);
        }

        /// <summary>
        /// Logs an error message with a specific color.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Text message color.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogError(object message, Color color, Object context = null)
        {
#if UNITY_EDITOR
            message = GetColoredMessage(message, color);
#endif
            Debug.LogError(message, context);
        }

        /// <summary>
        /// Logs a formated error message.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogErrorFormat(string format, params object[] args)
        {
            Debug.LogErrorFormat(format, args);
        }

        /// <summary>
        /// Logs an warning message.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogWarning(object message, Object context = null)
        {
            Debug.LogWarning(message, context);
        }

        /// <summary>
        /// Logs an warning message with a specific color.
        /// </summary>
        /// <param name="message">String or object to be converted to string representation for display.</param>
        /// <param name="color">Text message color.</param>
        /// <param name="context">Object to which the message applies.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogWarning(object message, Color color, Object context = null)
        {
#if UNITY_EDITOR
            message = GetColoredMessage(message, color);
#endif
            Debug.LogWarning(message, context);
        }

        /// <summary>
        /// Logs a formated error message.
        /// </summary>
        /// <param name="logType">Type of message e.g. warn or error etc.</param>
        /// <param name="logOptions">Option flags to treat the log message special.</param>
        /// <param name="context">Object to which the message applies.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">Format arguments.</param>
        [System.Diagnostics.Conditional(LOGGING_DIRECTIVE)]
        public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
        {
            Debug.LogFormat(logType, logOptions, context, format, args);
        }

        private static object GetColoredMessage(object message, Color color)
        {
            Color32 c32 = color;
            
            return $"<color=#{ColorUtility.ToHtmlStringRGB(c32)}>{message}</color>";
        }

        #endregion
    }
}
