'use client';
import AsideBar from '@components/organisms/AsideBar';
import Nav from '@components/organisms/Nav';

interface AuthLayoutProps {
  children: React.ReactNode;
}

const AuthLayout: React.FC<AuthLayoutProps> = ({ children }) => {
  return (
    <section className='w-full h-screen flex flex-row'>
      <AsideBar />
      <div className='w-full p-10'>
        <Nav />
        {children}
      </div>
    </section>
  );
};

export default AuthLayout;
