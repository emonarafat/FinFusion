using Finfusion.Domain.Core.Abstractions;
using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Entities;

/// <summary>
/// The chart of accounts level.
/// </summary>
public partial class Chart_Of_Accounts_Level : AggregateRoot, IAuditableEntity, ISoftDeletableEntity
{
  #region "Private Variables"
  /// <summary>
  /// The client company id.
  /// </summary>
  private Ulid _clientCompanyId;

  /// <summary>
  /// The chart of accounts id.
  /// </summary>
  private Ulid _chartOfAccountsId;

  /// <summary>
  /// Level.
  /// </summary>
  private byte _level;

  /// <summary>
  /// The length.
  /// </summary>
  private byte _length;

  /// <summary>
  /// The record status.
  /// </summary>
  private byte _recordStatus;
  /// <summary>
  /// The maker id.
  /// </summary>
  private Ulid _makerId;

  /// <summary>
  /// Make date.
  /// </summary>
  private DateTimeOffset _makeDate;

  /// <summary>
  /// The checker id.
  /// </summary>
  private Ulid? _checkerId;

  /// <summary>
  /// Check date.
  /// </summary>
  private DateTimeOffset? _modifiedOnUtc;

  /// <summary>
  /// The authorizer id.
  /// </summary>
  private Ulid? _authorizerId;

  /// <summary>
  /// The deleted.
  /// </summary>
  private bool _deleted;
  /// <summary>
  /// The authorize date.
  /// </summary>
  private DateTimeOffset? _deletedOnUtc;


  /// <summary>
  /// The authorize date.
  /// </summary>
  private DateTimeOffset? _authorizeDate;

  /// <summary>
  /// The record action type.
  /// </summary>
  private byte _recordActionType;
  #endregion

  #region "Public Properties"

  /// <summary>
  /// ClientCompanyId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Ulid</returns>


  public Ulid ClientCompanyId
  {
    get { return _clientCompanyId; }
    set
    {
      if (_clientCompanyId != value)
      {
        _clientCompanyId = value;
      }
    }
  }



  /// <summary>
  /// ChartOfAccountsId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Ulid</returns>


  public Ulid ChartOfAccountsId
  {
    get { return _chartOfAccountsId; }
    set
    {
      if (_chartOfAccountsId != value)
      {
        _chartOfAccountsId = value;
      }
    }
  }

  /// <summary>
  /// Gets or sets the chart of account.
  /// </summary>
  /// <value>A <see cref="Chart_Of_Accounts"/></value>
  public virtual Chart_Of_Accounts? ChartOfAccount { get; set; }

  /// <summary>
  /// Level Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Byte</returns>


  public byte Level
  {
    get { return _level; }
    set
    {
      if (_level != value)
      {
        _level = value;
      }
    }
  }



  /// <summary>
  /// Length Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Byte</returns>


  public byte Length
  {
    get { return _length; }
    set
    {
      if (_length != value)
      {
        _length = value;
      }
    }
  }



  /// <summary>
  /// RecordStatus Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Byte</returns>


  public byte RecordStatus
  {
    get { return _recordStatus; }
    set
    {
      if (_recordStatus != value)
      {
        _recordStatus = value;
      }
    }
  }



  /// <summary>
  /// CreatorId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Ulid</returns>


  public Ulid CreatorId
  {
    get => _makerId;
    set
    {
      if (_makerId != value)
      {
        _makerId = value;
      }
    }
  }



  /// <summary>
  /// MakeDate Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset CreatedOnUtc
  {
    get => _makeDate;
    set
    {
      if (_makeDate != value)
      {
        _makeDate = value;
      }
    }
  }



  /// <summary>
  /// ModifierId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Int16</returns>


  public Ulid? ModifierId
  {
    get => _checkerId;
    set
    {
      if (_checkerId != value)
      {
        _checkerId = value;
      }
    }
  }



  /// <summary>
  /// CheckDate Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset? ModifiedOnUtc
  {
    get => _modifiedOnUtc;
    set
    {
      if (_modifiedOnUtc != value)
      {
        _modifiedOnUtc = value;
      }
    }
  }



  /// <summary>
  /// AuthorizerId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Int16</returns>


  public Ulid? AuthorizerId
  {
    get => _authorizerId;
    set
    {
      if (_authorizerId != value)
      {
        _authorizerId = value;
      }
    }
  }


  /// <summary>
  /// AuthorizeDate Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset? AuthorizeDate
  {
    get => _authorizeDate;
    set
    {
      if (_authorizeDate != value)
      {
        _authorizeDate = value;
      }
    }
  }

  /// <summary>
  /// Deleted Property
  /// </summary>
  /// <value></value>
  /// <returns>  /// <returns>System.Boolean</returns></returns>


  public bool Deleted
  {
    get => _deleted;
    set
    {
      if (_deleted != value)
      {
        _deleted = value;
      }
    }
  }



  /// <summary>
  /// AuthorizeDate Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset? DeletedOnUtc
  {
    get => _deletedOnUtc;
    set
    {
      if (_deletedOnUtc != value)
      {
        _deletedOnUtc = value;
      }
    }
  }

  /// <summary>
  /// RecordActionType Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Byte</returns>


  public byte RecordActionType
  {
    get { return _recordActionType; }
    set
    {
      if (_recordActionType != value)
      {
        _recordActionType = value;
      }
    }
  }

  #endregion
}

