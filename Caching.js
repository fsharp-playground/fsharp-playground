
var k = 0;

function aeiou() {
  k = k + 1
  var ls = ["a", "e", "i", "o", "u"];
  return function(input) {
    return ls.indexOf(input) != -1;
  };
}

var f = aeiou()
f("a")
k
k
f("b")
k

k
aeiou()("a")
k
aeiou()("i")
k