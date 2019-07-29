using System;
using System.Text;

namespace NekoTool.Lang.Str
{
	/// <summary>
	/// A better <see cref="StringBuilder"/>
	/// </summary>
	public class NekoSB
	{
		private readonly StringBuilder sb;

		/// <summary>
		/// Gets the char at the index.
		/// </summary>
		/// <param name="i"></param>
		/// <returns></returns>
		public char this[int i]
		{
			get => sb[i];
			set => sb[i] = value;
		}

		/// <summary>
		/// The length. Same as <see cref="StringBuilder.Length"/>.
		/// </summary>
		public int Length => sb.Length;

		/// <summary>
		/// Same as <see cref="StringBuilder()"/>.
		/// </summary>
		public NekoSB()
		{
			sb = new StringBuilder();
		}

		public NekoSB(string s)
		{
			sb = new StringBuilder(s);
		}

		/// <summary>
		/// Same as <see cref="StringBuilder(int)"/>
		/// </summary>
		/// <param name="capacity"></param>
		public NekoSB(int capacity)
		{
			sb = new StringBuilder(capacity);
		}

		/// <summary>
		/// Same as <see cref="StringBuilder.Append(string)"/>.
		/// <inheritdoc cref="StringBuilder.Append(string)"/>
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public NekoSB Append(string s)
		{
			sb.Append(s);
			return this;
		}

		public NekoSB Append(int i)
		{
			sb.Append(i);
			return this;
		}

		/// <summary>
		/// Same as <see cref="StringBuilder.AppendLine()"/>
		/// </summary>
		/// <returns></returns>
		public NekoSB AppendLine()
		{
			sb.AppendLine();
			return this;
		}

		/// <summary>
		/// Same as <see cref="StringBuilder.AppendLine(string)"/>
		/// </summary>
		/// <returns></returns>
		public NekoSB AppendLine(string s)
		{
			sb.AppendLine(s);
			return this;
		}

		public NekoSB DeleteCharAt(int idx)
		{
			sb.Remove(idx, 1);
			return this;
		}

		/// <summary>
		/// Removes the last character.
		/// </summary>
		/// <returns></returns>
		public NekoSB DeleteLastChar()
		{
			sb.Remove(sb.Length - 1, 1);
			return this;
		}

		public NekoSB DeleteLastChars(int num)
		{
			if (num <= 0)
				return this;
			if (num > sb.Length)
				num = sb.Length;
			sb.Remove(sb.Length - num, num);
			return this;
		}

		public NekoSB Insert(int index, char c)
		{
			sb.Insert(index, c);
			return this;
		}

		public NekoSB Insert(int index, string s)
		{
			sb.Insert(index, s);
			return this;
		}

		public NekoSB Clear()
		{
			sb.Clear();
			return this;
		}

		public NekoSB Replace(int idx, char c)
		{
			sb[idx] = c;
			return this;
		}

		public NekoSB Replace(int idx, string val)
		{
			int count = 0;
			while (idx < sb.Length && count < val.Length)
			{
				sb[idx] = val[count];
				idx++;
				count++;
			}

			if (count < val.Length)
			{
				sb.Append(val.Substring(count));
			}

			return this;
		}

		/// <summary>
		/// Repeat the string multiple times.
		/// </summary>
		/// <param name="times"></param>
		/// <returns></returns>
		public NekoSB Repeat(int times)
		{
			if (times < 1)
				throw new ArgumentOutOfRangeException(nameof(times), "Out of range");
			if (times == 1)
				return this;
			string repeat = sb.ToString();
			for (int i = 0; i < times - 1; i++)
			{
				sb.Append(repeat);
			}

			return this;
		}

		public static bool operator ==(NekoSB sb1, NekoSB sb2)
		{
			return sb1 != null && sb1.Equals(sb2);
		}

		public static bool operator !=(NekoSB sb1, NekoSB sb2)
		{
			return !(sb1 == sb2);
		}

		public static implicit operator string(NekoSB sb)
		{
			return sb.ToString();
		}

		public static implicit operator NekoSB(string s)
		{
			return new NekoSB(s);
		}

		public override string ToString()
		{
			return sb.ToString();
		}

		public override bool Equals(object obj)
		{
			return sb.Equals(obj);
		}

		public bool Equals(NekoSB other)
		{
			return Equals(sb, other.sb);
		}

		public override int GetHashCode()
		{
			return (sb != null ? sb.GetHashCode() : 0);
		}

		private bool IsOutOfBounds(int index)
		{
			return index < 0 || index >= sb.Length;
		}
	}
}
