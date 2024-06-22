using Finfusion.Domain.Core.Abstractions;
using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Entities;

/// <summary>
/// The chart of accounts type.
/// </summary>
public class Chart_Of_Accounts_Type : AggregateRoot, IAuditableEntity, ISoftDeletableEntity
{
  #region "Private Variables"

  /// <summary>
  /// The client company id.
  /// </summary>
  private Ulid _clientCompanyId;

  /// <summary>
  /// The chart of accounts type name.
  /// </summary>
  private string _chartOfAccountsTypeName = string.Empty;
  /// <summary>
  /// The reference column name.
  /// </summary>
  private string _referenceColumnName = string.Empty;
  /// <summary>
  /// The related table name.
  /// </summary>
  private string _RelatedTableName = string.Empty;

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
  /// The modified on utc.
  /// </summary>
  private DateTimeOffset? _modifiedOnUtc;
  /// <summary>
  /// The checker id.
  /// </summary>
  private Ulid? _checkerId;
  /// <summary>
  /// The authorizer id.
  /// </summary>
  private Ulid? _authorizerId;

  private bool _deleted;
  /// <summary>
  /// The authorize date.
  /// </summary>
  private DateTimeOffset? _deletedOnUtc;
  /// <summary>
  /// The authorize date.
  /// </summary>
  private DateTimeOffset _authorizeDate;

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
  /// <returns>System.Int16</returns>


  public Ulid ClientCompanyId
  {
    get
    {
      return _clientCompanyId;
    }
    set
    {
      if (_clientCompanyId != value)
      {
        _clientCompanyId = value;
      }
    }
  }



  /// <summary>
  /// ChartOfAccountsTypeName Property
  /// </summary>
  /// <value></value>
  /// <returns>System.String</returns>


  public string ChartOfAccountsTypeName
  {
    get
    {
      return _chartOfAccountsTypeName;
    }
    set
    {
      if (_chartOfAccountsTypeName != value)
      {
        _chartOfAccountsTypeName = value;
      }
    }
  }
  /// <summary>
  /// Gets or sets the related table name.
  /// </summary>
  /// <value>A <see cref="string"/></value>
  public string RelatedTableName
  {
    get
    {
      return _RelatedTableName;
    }
    set
    {
      if (_RelatedTableName != value)
      {
        _RelatedTableName = value;
      }
    }
  }
  /// <summary>
  /// Gets or sets the reference column name.
  /// </summary>
  /// <value>A <see cref="string"/></value>
  public string ReferenceColumnName
  {
    get
    {
      return _referenceColumnName;
    }
    set
    {
      if (_referenceColumnName != value)
      {
        _referenceColumnName = value;
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
    get
    {
      return _recordStatus;
    }
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
  /// <returns>System.Int16</returns>


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
    get
    {
      return _authorizerId;
    }
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


  public DateTimeOffset AuthorizeDate
  {
    get
    {
      return _authorizeDate;
    }
    set
    {
      if (_authorizeDate != value)
      {
        _authorizeDate = value;
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
    get
    {
      return _recordActionType;
    }
    set
    {
      if (_recordActionType != value)
      {
        _recordActionType = value;
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

  #endregion
}

