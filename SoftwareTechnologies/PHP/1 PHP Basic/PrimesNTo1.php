
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Primes</title>
</head>
<body>
    <?php

        if (isset($_GET['num'])) {
            $num = intval($_GET['num']);
             function isPrime($n)
             {
                 $i = 2;
                 if ($n == 2) {
                     return true;
                 }
                 while ($i < $n) {
                     if ($n % $i == 0) {
                         return false;
                     }
                     $i++;
                 }
                 return true;
             }

             for ($i = $num; $i > 1; $i--) {
                 if (isPrime($i)) {
                     echo "$i\n";
                 }
             }

        }
    ?>
    <form>
        <div>Number:</div><input type="number" name="num">
        <div><input type="submit" value="Submit"></div>
    </form>
</body>
</html>