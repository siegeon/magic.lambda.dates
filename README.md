
# Magic Lambda Dates

[![Build status](https://travis-ci.org/polterguy/magic.lambda.dates.svg?master)](https://travis-ci.org/polterguy/magic.lambda.dates)

Date manipulation library for [Magic](https://github.com/polterguy/magic). More specifically, it gives you the following slots.

* __[date.now]__ - Returns the now date, equivalent of `DateTime.Now`.
* __[date.format]__ - Returns a string representation of some date, formatted according to the specified **[format]** argument.
* __[time]__ - Creates a time span, useful for adding and subtracting offsets to date objects. Pass in **[days]**, **[hours]**, **[minutes]**, **[seconds]** and **[milliseconds]** to declare how large your offset is. All arguments are optional, but (of course) on argument should be passed in.

**Notice** - Internally in Magic, everything is UTC us Universal timezone, implying if you want to render it in user's
timezone, you'll have to convert it explicitly. All dates and times internally in  Magic, also those stored into any database,
are treated as UTC timezone.
