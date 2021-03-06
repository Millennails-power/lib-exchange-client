# coding: utf-8

"""
    Blockchain.com Exchange REST API

    ## Introduction Welcome to Blockchain.com's Exchange API and developer documentation. \\ These documents detail and give examples of various functionality offered by the API such as receiving real time market data, requesting balance information and performing trades. ## To Get Started Create or log into your existing Blockchain.com Exchange account \\ Select API from the drop down menu \\ Fill out form and click “Create New API Key Now” \\ Once generated you can view your keys under API Settings. \\ Please be aware that the API key can only be used once it was verified via email.  The API key must be set via the \\ `X-API-Token`\\ header.  The base URL to be used for all calls is \\ `https://api.blockchain.com/v3/exchange`  Autogenerated clients for this API can be found [here](https://github.com/blockchain/lib-exchange-client).   # noqa: E501

    The version of the OpenAPI document: 1.0.0
    Generated by: https://openapi-generator.tech
"""


import pprint
import re  # noqa: F401

import six

from openapi_client.configuration import Configuration


class WithdrawalInfo(object):
    """NOTE: This class is auto generated by OpenAPI Generator.
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    """
    Attributes:
      openapi_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    openapi_types = {
        'withdrawal_id': 'str',
        'amount': 'float',
        'fee': 'float',
        'currency': 'str',
        'beneficiary': 'str',
        'state': 'WithdrawalStatus',
        'timestamp': 'int'
    }

    attribute_map = {
        'withdrawal_id': 'withdrawalId',
        'amount': 'amount',
        'fee': 'fee',
        'currency': 'currency',
        'beneficiary': 'beneficiary',
        'state': 'state',
        'timestamp': 'timestamp'
    }

    def __init__(self, withdrawal_id=None, amount=None, fee=None, currency=None, beneficiary=None, state=None, timestamp=None, local_vars_configuration=None):  # noqa: E501
        """WithdrawalInfo - a model defined in OpenAPI"""  # noqa: E501
        if local_vars_configuration is None:
            local_vars_configuration = Configuration()
        self.local_vars_configuration = local_vars_configuration

        self._withdrawal_id = None
        self._amount = None
        self._fee = None
        self._currency = None
        self._beneficiary = None
        self._state = None
        self._timestamp = None
        self.discriminator = None

        if withdrawal_id is not None:
            self.withdrawal_id = withdrawal_id
        self.amount = amount
        if fee is not None:
            self.fee = fee
        self.currency = currency
        self.beneficiary = beneficiary
        if state is not None:
            self.state = state
        if timestamp is not None:
            self.timestamp = timestamp

    @property
    def withdrawal_id(self):
        """Gets the withdrawal_id of this WithdrawalInfo.  # noqa: E501

        Unique ID for this withdrawal  # noqa: E501

        :return: The withdrawal_id of this WithdrawalInfo.  # noqa: E501
        :rtype: str
        """
        return self._withdrawal_id

    @withdrawal_id.setter
    def withdrawal_id(self, withdrawal_id):
        """Sets the withdrawal_id of this WithdrawalInfo.

        Unique ID for this withdrawal  # noqa: E501

        :param withdrawal_id: The withdrawal_id of this WithdrawalInfo.  # noqa: E501
        :type: str
        """

        self._withdrawal_id = withdrawal_id

    @property
    def amount(self):
        """Gets the amount of this WithdrawalInfo.  # noqa: E501

        The amount to withdraw in the currency specified  # noqa: E501

        :return: The amount of this WithdrawalInfo.  # noqa: E501
        :rtype: float
        """
        return self._amount

    @amount.setter
    def amount(self, amount):
        """Sets the amount of this WithdrawalInfo.

        The amount to withdraw in the currency specified  # noqa: E501

        :param amount: The amount of this WithdrawalInfo.  # noqa: E501
        :type: float
        """
        if self.local_vars_configuration.client_side_validation and amount is None:  # noqa: E501
            raise ValueError("Invalid value for `amount`, must not be `None`")  # noqa: E501

        self._amount = amount

    @property
    def fee(self):
        """Gets the fee of this WithdrawalInfo.  # noqa: E501

        The amount charged in fees for this withdrawal  # noqa: E501

        :return: The fee of this WithdrawalInfo.  # noqa: E501
        :rtype: float
        """
        return self._fee

    @fee.setter
    def fee(self, fee):
        """Sets the fee of this WithdrawalInfo.

        The amount charged in fees for this withdrawal  # noqa: E501

        :param fee: The fee of this WithdrawalInfo.  # noqa: E501
        :type: float
        """

        self._fee = fee

    @property
    def currency(self):
        """Gets the currency of this WithdrawalInfo.  # noqa: E501


        :return: The currency of this WithdrawalInfo.  # noqa: E501
        :rtype: str
        """
        return self._currency

    @currency.setter
    def currency(self, currency):
        """Sets the currency of this WithdrawalInfo.


        :param currency: The currency of this WithdrawalInfo.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and currency is None:  # noqa: E501
            raise ValueError("Invalid value for `currency`, must not be `None`")  # noqa: E501
        if (self.local_vars_configuration.client_side_validation and
                currency is not None and not re.search(r'^[A-Z]{3,5}$', currency)):  # noqa: E501
            raise ValueError(r"Invalid value for `currency`, must be a follow pattern or equal to `/^[A-Z]{3,5}$/`")  # noqa: E501

        self._currency = currency

    @property
    def beneficiary(self):
        """Gets the beneficiary of this WithdrawalInfo.  # noqa: E501


        :return: The beneficiary of this WithdrawalInfo.  # noqa: E501
        :rtype: str
        """
        return self._beneficiary

    @beneficiary.setter
    def beneficiary(self, beneficiary):
        """Sets the beneficiary of this WithdrawalInfo.


        :param beneficiary: The beneficiary of this WithdrawalInfo.  # noqa: E501
        :type: str
        """
        if self.local_vars_configuration.client_side_validation and beneficiary is None:  # noqa: E501
            raise ValueError("Invalid value for `beneficiary`, must not be `None`")  # noqa: E501

        self._beneficiary = beneficiary

    @property
    def state(self):
        """Gets the state of this WithdrawalInfo.  # noqa: E501


        :return: The state of this WithdrawalInfo.  # noqa: E501
        :rtype: WithdrawalStatus
        """
        return self._state

    @state.setter
    def state(self, state):
        """Sets the state of this WithdrawalInfo.


        :param state: The state of this WithdrawalInfo.  # noqa: E501
        :type: WithdrawalStatus
        """

        self._state = state

    @property
    def timestamp(self):
        """Gets the timestamp of this WithdrawalInfo.  # noqa: E501

        Time in ms since 01/01/1970 (epoch)  # noqa: E501

        :return: The timestamp of this WithdrawalInfo.  # noqa: E501
        :rtype: int
        """
        return self._timestamp

    @timestamp.setter
    def timestamp(self, timestamp):
        """Sets the timestamp of this WithdrawalInfo.

        Time in ms since 01/01/1970 (epoch)  # noqa: E501

        :param timestamp: The timestamp of this WithdrawalInfo.  # noqa: E501
        :type: int
        """

        self._timestamp = timestamp

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.openapi_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, WithdrawalInfo):
            return False

        return self.to_dict() == other.to_dict()

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        if not isinstance(other, WithdrawalInfo):
            return True

        return self.to_dict() != other.to_dict()
