#region License
/*
 * NetworkCredential.cs
 *
 * The MIT License
 *
 * Copyright (c) 2014-2015 sta.blockhead
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
#endregion

using System;

namespace WebSocketSharp.Net
{
  /// <summary>
  /// Provides the credentials for the password-based authentication.
  /// </summary>
  public class NetworkCredential
  {
    #region Private Fields

    private string   _domain;
    private string   _password;
    private string[] _roles;
    private string   _username;

    #endregion

    #region Public Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkCredential"/> class with
    /// the specified <paramref name="username"/> and <paramref name="password"/>.
    /// </summary>
    /// <param name="username">
    /// A <see cref="string"/> that represents the username associated with
    /// the credentials.
    /// </param>
    /// <param name="password">
    /// A <see cref="string"/> that represents the password for the username
    /// associated with the credentials.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="username"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// <paramref name="username"/> is empty.
    /// </exception>
    public NetworkCredential (string username, string password)
      : this (username, password, null, null)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NetworkCredential"/> class with
    /// the specified <paramref name="username"/>, <paramref name="password"/>,
    /// <paramref name="domain"/> and <paramref name="roles"/>.
    /// </summary>
    /// <param name="username">
    /// A <see cref="string"/> that represents the username associated with
    /// the credentials.
    /// </param>
    /// <param name="password">
    /// A <see cref="string"/> that represents the password for the username
    /// associated with the credentials.
    /// </param>
    /// <param name="domain">
    /// A <see cref="string"/> that represents the domain associated with
    /// the credentials.
    /// </param>
    /// <param name="roles">
    /// An array of <see cref="string"/> that represents the roles
    /// associated with the credentials if any.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <paramref name="username"/> is <see langword="null"/>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// <paramref name="username"/> is empty.
    /// </exception>
    public NetworkCredential (
      string username, string password, string domain, params string[] roles
    )
    {
      if (username == null)
        throw new ArgumentNullException ("username");

      if (username.Length == 0)
        throw new ArgumentException ("An empty string.", "username");

      _username = username;
      _password = password;
      _domain = domain;
      _roles = roles;
    }

    #endregion

    #region Public Properties

    /// <summary>
    /// Gets the domain associated with the credentials.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> that represents the domain name.
    /// </value>
    public string Domain {
      get {
        return _domain ?? String.Empty;
      }

      internal set {
        _domain = value;
      }
    }

    /// <summary>
    /// Gets the password for the username associated with the credentials.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> that represents the password for the username.
    /// </value>
    public string Password {
      get {
        return _password ?? String.Empty;
      }

      internal set {
        _password = value;
      }
    }

    /// <summary>
    /// Gets the role names to which the user associated with the credentials belongs.
    /// </summary>
    /// <value>
    /// An array of <see cref="string"/> that contains the role names to which
    /// the user associated with the credentials belongs if any.
    /// </value>
    public string[] Roles {
      get {
        return _roles ?? (_roles = new string[0]);
      }

      internal set {
        _roles = value;
      }
    }

    /// <summary>
    /// Gets the user name associated with the credentials.
    /// </summary>
    /// <value>
    /// A <see cref="string"/> that represents the user name associated with the credentials.
    /// </value>
    public string UserName {
      get {
        return _username;
      }

      internal set {
        _username = value;
      }
    }

    #endregion
  }
}
