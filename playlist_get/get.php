<?php

	$files1 = scandir(".");
	$tmp=$files1[mt_rand(2, count($files1)-1)];
	while($tmp=="get.php"){
		$tmp=$files1[mt_rand(2, count($files1)-1)];
	}
	$files2 = scandir($tmp."/");
	$tmp2=$files2[mt_rand(2, count($files2)-1)];
	while($tmp2=="get.php"){
		$tmp2=$files2[mt_rand(2, count($files2)-1)];
	}
	echo $tmp."/".$tmp2;
	
?>