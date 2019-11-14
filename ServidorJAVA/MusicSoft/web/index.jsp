<%@page import="pe.edu.pucp.musicsoft.config.DBController"%>
<%@page import="pe.edu.pucp.musicsoft.model.AlbumMusical"%>
<%@page import="java.util.ArrayList"%>
<%
    ArrayList<AlbumMusical> albumes = DBController.listarAlbumesMusicales("");
%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <link href="main.css" rel="stylesheet" type="text/css">
        <title>Lista de Álbumes</title>
    </head>
    <body>
        <h1>Lista de Álbumes</h1>
        <form action="Prueba" method="get">
        <table style="border:1px solid black;">
        <tr>
            <th>Id del Álbum</th>
            <th>Nombre del Álbum</th>
            <th>Nombre del Artista</th>
            <th></th>
        </tr>
        <% for(int i=0; i<albumes.size(); i++){ %>
        <tr>
            <td><label name="idAlbum"><%= albumes.get(i).getIdAlbum() %></label></td>
            <td > <%= albumes.get(i).getNombreAlbum() %></td>
            <td > <%= albumes.get(i).getArtista().getNombreArtista() %></td>
            <td>
                <input name="idAlbum" type="submit" value="Generar Reporte Disco <%= albumes.get(i).getIdAlbum()%>"/>
            </td>
        </tr>
        <%}%>
        </table>
    </form>
    </body>
</html>