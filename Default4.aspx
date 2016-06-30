<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default4.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="bootstrap-3.3.2-dist/js/jquery-1.8.2.min.js"></script>
    <script>        $(function () {

            $.post("Default6.aspx", function (data, textState) {
                var obj = jQuery.parseJSON(data)
                $.each(obj, function (index, item) {
                    alert(item.title);
                    $("#lb_list").append("<option value=" + item.id + ">" + item.title + "</option>")
                })
            })
            //添加到右边
            $('#Button1').click(function () {

                var slt_length = $('#lb_list_sel>option').length; //不能放for循环，会造成死循环

                var ishave = false; //是否存在

                for (var i = 0; i < slt_length; i++) {
                    if ($('#lb_list').find("option:selected").prop('value') == $('#lb_list_sel>option').eq(i).prop('value')) {
                        ishave = false;
                        break;
                    } ishave = true;
                }
                if (slt_length == 0) {
                    ishave = true;
                }
                if (ishave) {
                    var temp = $('#lb_list').find("option:selected").clone(); //如果这不用clone,那左侧的option项就会减少
                    $(temp).appendTo('#lb_list_sel');
                }
                var slt_fids = '';
                for (var i = 0; i < $('#lb_list_sel>option').length; i++) {
                    slt_fids += $('#lb_list_sel>option').eq(i).prop('value') + ',' + $('#lb_list_sel>option').eq(i).prop('text') + '|';
                }
                $('#hf_slt_fids').val(slt_fids); //需要传到服务器的值
            })

            //后边删除
            $("#lb_list").click(function () {
                var slt_length = $('#lb_list_sel>option').length; //不能放for循环，会造成死循环

                var ishave = false; //是否存在

                for (var i = 0; i < slt_length; i++) {
                    if ($('#lb_list').find("option:selected").prop('value') == $('#lb_list_sel>option').eq(i).prop('value')) {
                        ishave = false;
                        break;
                    } ishave = true;
                }
                if (slt_length == 0) {
                    ishave = true;
                }
                if (ishave) {
                    var temp = $('#lb_list').find("option:selected").clone(); //如果这不用clone,那左侧的option项就会减少
                    $(temp).appendTo('#lb_list_sel');
                }
                var slt_fids = '';
                for (var i = 0; i < $('#lb_list_sel>option').length; i++) {
                    slt_fids += $('#lb_list_sel>option').eq(i).prop('value') + ',' + $('#lb_list_sel>option').eq(i).prop('text') + '|';
                }
                $('#hf_slt_fids').val(slt_fids);
            })
            $('#lb_list_sel').click(function () {
                $('#lb_list_sel').find("option:selected").remove(); //或者 $('#lb_list_sel>option:eq(索引)')
                var slt_fids = '';
                for (var i = 0; i < $('#lb_list_sel>option').length; i++) {
                    slt_fids += $('#lb_list_sel>option').eq(i).prop('value') + ',' + $('#lb_list_sel>option').eq(i).prop('text') + '|';
                }
                $('#hf_slt_fids').val(slt_fids);  //隐藏域值格式 value,text|value,text|

            })

        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <ul>
      <li style="height: 250px; margin: 5px 0px">权限列表<br />

                <select size="4" name="lb_list" multiple="multiple" id="lb_list" style="height:200px;width:150px;">
<%--
    <option value="1">后台登录</option>

    <option value="2">密码修改</option>

    <option value="3">新闻添加</option>

    <option value="4">新闻编辑</option>

    <option value="5">新闻删除</option>

    <option value="6">新闻发布</option>--%>



</select>

           

            </li>

            <li style="padding-top: 110px">==========>><br />

                <<==========</li><li style="height: 250px; margin: 5px 0px">当前权限<br />

                    <select size="4" name="lb_list_sel" multiple="multiple" id="lb_list_sel" style="height:200px;width:150px;">

   <%-- <option value="1">后台登录</option>

    <option value="2">密码修改</option>

    <option value="3">新闻添加</option>--%>

                        <input id="Button1" type="button" value="button" />
                        <input id="hf_slt_fids" type="text" />
</select>

                </li></ul>
    </div>

    </form>
</body>
</html>
