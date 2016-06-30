<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xmlstring.aspx.cs" Inherits="xmlstring" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="bootstrap-3.3.2-dist/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <script src="bootstrap-3.3.2-dist/js/jquery.min.js" type="text/javascript"></script>
    <script src="bootstrap-3.3.2-dist/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <script>
        $(function () {
            $("#<%=Button1.ClientID%>").click(function () {
                $("#groupSel .active").each(function () {
                    alert($(this).children(":checkbox").val());
                })
                return false;
            })
        })
    </script>
   
</head>
<body>
    <form id="form1" runat="server">
<div class="container">
  <div class="jumbotron">
    <h1>我的第一个 Bootstrap 页面</h1>
    <p>重置窗口大小，查看响应式效果！</p> 
  </div>
  <div class="row">
    <div class="col-sm-4">
      <h3>第一列</h3>
      <p>学的不仅是技术，更是梦想！</p>
      <p>再牛逼的梦想,也抵不住你傻逼似的坚持！</p>
    </div>
    <div class="col-sm-4">
      <h3>第二列</h3>
      <p>学的不仅是技术，更是梦想！</p>
      <p>再牛逼的梦想,也抵不住你傻逼似的坚持！</p>
    </div>
    <div class="col-sm-4">
      <h3>第三列</h3>        
      <p>学的不仅是技术，更是梦想！</p>
      <p>再牛逼的梦想,也抵不住你傻逼似的坚持！</p>
    </div>
  </div>
</div>
<input class="Wdate" id="Name" name="Name" onFocus="WdatePicker({isShowClear:false,dateFmt:'yyyy/MM/dd'})" type="text" value="111">
<asp:Button ID="Button1"
    runat="server" Text="Button"  />

     <asp:Button ID="Button2" runat="server" Text="写" onclick="Button2_Click" />
    <asp:Button ID="Button3" runat="server" Text="读" onclick="Button3_Click" />
    </form>
    <div class="btn-group" data-toggle="buttons" id="groupSel">
   <label class="btn btn-primary">
      <input type="checkbox" value="1"> 选项 1
   </label>
   <label class="btn btn-primary">
      <input type="checkbox" value="2"> 选项 2
   </label>
   <label class="btn btn-primary">
      <input type="checkbox" value="3"> 选项 3
   </label>
</div>
<asp:Label ID="lblType" runat="server" Text=""></asp:Label>

    <img  src="img.jpg" onerror="this.onerror='';this.src='Scripts/error.jpg'" class="img-responsive img-circle" alt="Cinque Terre"/>
   
</body>
</html>
