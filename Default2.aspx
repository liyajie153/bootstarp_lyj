<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap-3.3.2-dist/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="bootstrap-3.3.2-dist/js/jquery.min.js" type="text/javascript"></script>
    <script src="bootstrap-3.3.2-dist/js/bootstrap.min.js" type="text/javascript"></script>
   
</head>
<body>
   <div class="btn-group-vertical">
  <button type="button" class="btn btn-default">按钮 1</button>
  <button type="button" class="btn btn-default">按钮 2</button>

  <div class="btn-group-vertical">
    <button type="button" class="btn btn-default dropdown-toggle" 
      data-toggle="dropdown">
      下拉
      <span class="caret"></span>
    </button>
    <ul class="dropdown-menu">
      <li><a href="#">下拉链接 1</a></li>
      <li><a href="#">下拉链接 2</a></li>
    </ul>
  </div>
</div>
<div class="btn-group">
   <button type="button" class="btn btn-default dropdown-toggle" 
      data-toggle="dropdown">
      默认 <span class="caret"></span>
   </button>
   <ul class="dropdown-menu" role="menu">
      <li><a href="#">功能</a></li>
      <li><a href="#">另一个功能</a></li>
      <li><a href="#">其他</a></li>
      <li class="divider"></li>
      <li><a href="#">分离的链接</a></li>
   </ul>
</div>
<div class="btn-group">
   <button type="button" class="btn btn-primary dropdown-toggle" 
      data-toggle="dropdown">
      原始 <span class="caret"></span>
   </button>
   <ul class="dropdown-menu" role="menu">
      <li><a href="#">功能</a></li>
      <li><a href="#">另一个功能</a></li>
      <li><a href="#">其他</a></li>
      <li class="divider"></li>
      <li><a href="#">分离的链接</a></li>
   </ul>
</div>
</body>
</html>
