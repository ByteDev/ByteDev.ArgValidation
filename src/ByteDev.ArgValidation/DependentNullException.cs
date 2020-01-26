﻿using System;
using System.Runtime.Serialization;

namespace ByteDev.ArgValidation
{
    /// <summary>
    /// Represents a null error when injecting a dependent type.
    /// </summary>
    [Serializable]
    public class DependentNullException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.ArgValidation.DependentNullException" /> class.
        /// </summary>
        public DependentNullException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.ArgValidation.DependentNullException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public DependentNullException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.ArgValidation.DependentNullException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>       
        public DependentNullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ByteDev.ArgValidation.DependentNullException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"></see> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext"></see> that contains contextual information about the source or destination.</param>
        protected DependentNullException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}