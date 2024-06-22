using Finfusion.Domain.Core.Abstractions;
using Finfusion.Domain.Core.Primitives;

namespace Finfusion.Domain.Entities;

/// <summary>
/// The chart of accounts.
/// </summary>
public class Chart_Of_Accounts : AggregateRoot, IAuditableEntity, ISoftDeletableEntity
{
  #region "Private Variables"

  /// <summary>
  /// The client company id.
  /// </summary>
  private Ulid _clientCompanyId;

  /// <summary>
  /// The reference chart of accounts id.
  /// </summary>
  private Ulid? _referenceChartOfAccountsId;

  /// <summary>
  /// The chart of accounts type id.
  /// </summary>
  private Ulid _chartOfAccountsTypeId;

  /// <summary>
  /// Level.
  /// </summary>
  private byte _level;

  /// <summary>
  /// The account name.
  /// </summary>
  private string _accountName = string.Empty;


  /// <summary>
  /// The account short name.
  /// </summary>
  private string _accountShortName = string.Empty;


  /// <summary>
  /// The account display no.
  /// </summary>
  private string _accountDisplayNo = string.Empty;


  /// <summary>
  /// The debit credit.
  /// </summary>
  private bool _debitCredit;

  /// <summary>
  /// Is posting account.
  /// </summary>
  private bool _isPostingAccount;

  /// <summary>
  /// The account opening date.
  /// </summary>
  private DateTimeOffset _accountOpeningDate;

  /// <summary>
  /// The accoun opening balance.
  /// </summary>
  private decimal _accountOpeningBalance;
  /// <summary>
  /// The priority level.
  /// </summary>
  private byte _priorityLevel;
  /// <summary>
  /// Display in report.
  /// </summary>
  private byte _displayInReport;
  /// <summary>
  /// Is active.
  /// </summary>
  private bool _isActive;


  /// <summary>
  /// The active date.
  /// </summary>
  private DateTimeOffset _activeDate;


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
  private Ulid _checkerId;

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
    get => _clientCompanyId;
    set
    {
      if (_clientCompanyId != value)
      {
        _clientCompanyId = value;
      }
    }
  }


  /// <summary>
  /// ReferenceChartOfAccountsId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Ulid</returns>


  public Ulid? ReferenceChartOfAccountsId
  {
    get => _referenceChartOfAccountsId;
    set
    {
      if (_referenceChartOfAccountsId != value)
      {
        _referenceChartOfAccountsId = value;
      }
    }
  }


  /// <summary>
  /// Gets or sets the chart of accounts references.
  /// </summary>
  /// <value>A collection of chart_of_accounts.</value>
  public virtual ICollection<Chart_Of_Accounts> ChartOfAccountsReferences { get; set; } = [];

  /// <summary>
  /// ChartOfAccountsTypeId Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Ulid</returns>


  public Ulid ChartOfAccountsTypeId
  {
    get => _chartOfAccountsTypeId;
    set
    {
      if (_chartOfAccountsTypeId != value)
      {
        _chartOfAccountsTypeId = value;
      }
    }
  }

  /// <summary>
  /// Gets or sets the chart of accounts type.
  /// </summary>
  /// <value>A <see cref="Chart_Of_Accounts_Type"/></value>
  public virtual Chart_Of_Accounts_Type? Chart_Of_Accounts_Type { get; set; }


  /// <summary>
  /// Level Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Byte</returns>


  public byte Level
  {
    get => _level;
    set
    {
      if (_level != value)
      {
        _level = value;
      }
    }
  }



  /// <summary>
  /// AccountName Property
  /// </summary>
  /// <value></value>
  /// <returns>System.String</returns>


  public string AccountName
  {
    get => _accountName;
    set
    {
      if (_accountName != value)
      {
        _accountName = value;
      }
    }
  }



  /// <summary>
  /// Account ShortName Property
  /// </summary>
  /// <value></value>
  /// <returns>System.String</returns>


  public string AccountShortName
  {
    get => _accountShortName;
    set
    {
      if (_accountShortName != value)
      {
        _accountShortName = value;
      }
    }
  }



  /// <summary>
  /// Account Display No Property
  /// </summary>
  /// <value></value>
  /// <returns>System.String</returns>


  public string AccountDisplayNo
  {
    get => _accountDisplayNo;
    set
    {
      if (_accountDisplayNo != value)
      {
        _accountDisplayNo = value;
      }
    }
  }



  /// <summary>
  /// DebitCredit Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Boolean</returns>


  public bool DebitCredit
  {
    get => _debitCredit;
    set
    {
      if (_debitCredit != value)
      {
        _debitCredit = value;
      }
    }
  }



  /// <summary>
  /// IsPostingAccount Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Boolean</returns>


  public bool IsPostingAccount
  {
    get => _isPostingAccount;
    set
    {
      if (_isPostingAccount != value)
      {
        _isPostingAccount = value;
      }
    }
  }



  /// <summary>
  /// Account Opening Date Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset AccountOpeningDate
  {
    get => _accountOpeningDate;
    set
    {
      if (_accountOpeningDate != value)
      {
        _accountOpeningDate = value;
      }
    }
  }



  /// <summary>
  /// Account Opening Balance Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Decimal</returns>


  public decimal AccountOpeningBalance
  {
    get => _accountOpeningBalance;
    set
    {
      if (_accountOpeningBalance != value)
      {
        _accountOpeningBalance = value;
      }
    }
  }


  /// <summary>
  /// Gets or sets the priority level.
  /// </summary>
  /// <value>A <see cref="byte"/></value>
  public byte PriorityLevel
  {
    get => _priorityLevel;
    set
    {
      if (_priorityLevel != value)
      {
        _priorityLevel = value;
      }
    }
  }


  /// <summary>
  /// Gets or sets the display in report.
  /// </summary>
  /// <value>A <see cref="byte"/></value>
  public byte DisplayInReport
  {
    get => _displayInReport;
    set
    {
      if (_displayInReport != value)
      {
        _displayInReport = value;
      }
    }
  }



  /// <summary>
  /// IsActive Property
  /// </summary>
  /// <value></value>
  /// <returns>System.Boolean</returns>


  public bool IsActive
  {
    get => _isActive;
    set
    {
      if (_isActive != value)
      {
        _isActive = value;
      }
    }
  }



  /// <summary>
  /// ActiveDate Property
  /// </summary>
  /// <value></value>
  /// <returns>DateTimeOffset</returns>


  public DateTimeOffset ActiveDate
  {
    get => _activeDate;
    set
    {
      if (_activeDate != value)
      {
        _activeDate = value;
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
    get => _recordStatus;
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


  public Ulid ModifierId
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
    get => _recordActionType;
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


