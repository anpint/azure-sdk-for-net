// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Communication.Messages
{
    /// <summary> The message content of type ButtonSet/ List of buttons information. </summary>
    public partial class ButtonSetContent : MessageContent
    {
        /// <summary> Initializes a new instance of <see cref="ButtonSetContent"/>. </summary>
        /// <param name="buttons"> Unique Id of the button content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="buttons"/> is null. </exception>
        public ButtonSetContent(IEnumerable<ButtonContent> buttons)
        {
            Argument.AssertNotNull(buttons, nameof(buttons));

            Kind = MessageContentKind.ButtonSet;
            Buttons = buttons.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ButtonSetContent"/>. </summary>
        /// <param name="kind"> Kind of MessageContent. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="buttons"> Unique Id of the button content. </param>
        internal ButtonSetContent(MessageContentKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<ButtonContent> buttons) : base(kind, serializedAdditionalRawData)
        {
            Buttons = buttons;
        }

        /// <summary> Initializes a new instance of <see cref="ButtonSetContent"/> for deserialization. </summary>
        internal ButtonSetContent()
        {
        }

        /// <summary> Unique Id of the button content. </summary>
        public IList<ButtonContent> Buttons { get; }
    }
}
