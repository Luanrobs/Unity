# Unity_Invoke-Method-by-Stringname
call a function by its name

var function = typeof("TYPENAME").GetMethod("METHODNAME", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
      function.Invoke(this, null);
