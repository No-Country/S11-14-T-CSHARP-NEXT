

interface AsideBarItemProps {
    itemName: string,
    itemIcon: string,
}

const AsideBarItem: React.FC<AsideBarItemProps> = ({itemName, itemIcon}) => {
  return (
    <div className="font-roboto my-4 text-white cursor-pointer">{itemIcon} {itemName}</div>
  )
}

export default AsideBarItem