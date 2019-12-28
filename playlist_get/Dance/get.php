<?php
	$files1 = scandir(".");
	$tmp=$files1[mt_rand(2, count($files1)-1)];
	while($tmp=="get.php" or $tmp==""){
		$tmp=$files1[mt_rand(2, count($files1)-1)];
	}
	echo $tmp;
	
?>
