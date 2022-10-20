package practicum.registration;

import jakarta.servlet.RequestDispatcher;
import jakarta.servlet.ServletException;
import jakarta.servlet.annotation.WebServlet;
import jakarta.servlet.http.HttpServlet;
import jakarta.servlet.http.HttpServletRequest;
import jakarta.servlet.http.HttpServletResponse;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;


@WebServlet("/register")
public class RegistrationServlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
       
  
	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		String uname = request.getParameter("name");
		String fname = request.getParameter("firstname");
		String lname = request.getParameter("lastname");
		String birthdate = request.getParameter("birthdate");
		String uemail = request.getParameter("email");
		String upwd = request.getParameter("pass");
		String ucontact = request.getParameter("contact");
		RequestDispatcher dispatcher = null;
		Connection con = null;	
		try {
			Class.forName("com.mysql.cj.jdbc.Driver");
			con = DriverManager.getConnection("jdbc:mysql://localhost:3306/project001?useSSL=false","root","Anuleol22!");
			PreparedStatement pst = con.prepareStatement("insert into userinfo(uname,fname,lname,birthdate,uemail,upwd,ucontact)"
					+ "values(?,?,?,?,?,?,?)");
			pst.setString(1, uname);
			pst.setString(2, fname);
			pst.setString(3, lname);
			pst.setString(4, birthdate);
			pst.setString(5, uemail);
			pst.setString(6, upwd);
			pst.setString(7, ucontact);
			
			int rowCount = pst.executeUpdate();
			if (rowCount > 0) {
				request.setAttribute("status", "success");
				dispatcher = request.getRequestDispatcher("registration.jsp");
			}else {
				request.setAttribute("status", "failed");
			}
			dispatcher.forward(request, response);
		}catch (Exception e){
			e.printStackTrace();
		}finally {
			try {
				con.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		}
	}

}
