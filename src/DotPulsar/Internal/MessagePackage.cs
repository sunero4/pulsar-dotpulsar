﻿/*
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace DotPulsar.Internal;

using PulsarApi;
using System.Buffers;

public readonly struct MessagePackage
{
    public MessagePackage(MessageIdData messageId, uint redeliveryCount, ReadOnlySequence<byte> data)
    {
        MessageId = messageId;
        RedeliveryCount = redeliveryCount;
        Data = data;
    }

    public MessageIdData MessageId { get; }
    public uint RedeliveryCount { get; }
    public ReadOnlySequence<byte> Data { get; }
}
