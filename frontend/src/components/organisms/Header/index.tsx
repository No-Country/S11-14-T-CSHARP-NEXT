import Menu from "@components/molecules/Menu";


interface HeaderProps {}

const Header: React.FC<HeaderProps> = () => {
  return (
    <header className="w-full">
      <Menu/>
    </header>
  )
};

export default Header;